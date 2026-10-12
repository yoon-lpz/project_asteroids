using UnityEngine;
// TODO: crea el ScriptableObject [CreateAssetsMenu...] recorda que no ha d'heretar de MonoBehaviour
[CreateAssetMenu(fileName = "NewAsteroidData", menuName = "Game/Asteroid Data")]
public class AsteroidData : ScriptableObject
{
//TODO: introdueix les dades necesaties
    public int maxHealth;
    public Color color;
    public float scale;
    public float minSpeed;
    public float maxSpeed;
    public int damage;
    public int scoreValue;
}