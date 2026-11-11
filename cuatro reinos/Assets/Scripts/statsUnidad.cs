using UnityEngine;

[CreateAssetMenu(fileName = "statsUnidad", menuName = "Scriptable Objects/statsUnidad")]
public class statsUnidad : ScriptableObject
{
    public int tier;
    public string rol;
    public string rasgo;
    public int vida;
    public int ataque;
    public int armadura;
    public int res_magica;
    public int movimiento; // 1 - Lento, 2 - Normal, 3 - Rapido, ...
}
