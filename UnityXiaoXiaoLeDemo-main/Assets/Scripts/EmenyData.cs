using UnityEngine;


[CreateAssetMenu(fileName = "���a���", menuName = "Data/���a���")]
public class EmenyData : ScriptableObject
{
    // ��O��
    [Header("�ͩR��")]
    [Range(100, 10000)]
    public int hp = 100;

    [Header("�]�O��")]
    [Range(100, 10000)]
    public int mp = 100;

    [Header("�����O")]
    [Range(100, 10000)]
    public int atk = 100;

    [Header("���m�O")]
    [Range(100, 10000)]
    public int def = 100;

    


}