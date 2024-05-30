using UnityEngine;

public class CharacterManger : MonoBehaviour
{
    private static CharacterManger _instance;
    public static CharacterManger Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new GameObject("CharacterManager").AddComponent<CharacterManger>();
            }
            return _instance;
        }
    }

    public Player _player;
    public Player Player
    {
        get { return _player; }
        set { _player = value; }
    }

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if(_instance == this)
            {
                Destroy(gameObject);
            }
        }
    }
}
