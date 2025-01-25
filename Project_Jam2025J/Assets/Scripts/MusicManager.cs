using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager _musicManager;
    //private MusicManager()
    //{

    //}
    //public MusicManager GetMusicManager
    //{
    //    get
    //    {
    //    if (_musicManager == null)
    //        _musicManager = this;
    //        else
    //            Destroy(gameObject);
    //        return _musicManager;
    //    }
    //}
    void Start()
    {
        if (_musicManager == null)
        {
            _musicManager = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        //_musicManager = GetMusicManager;
        //DontDestroyOnLoad(gameObject);
    }


}
