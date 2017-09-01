using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgr : Sington<SceneMgr> {
	
    /// <summary>
    /// 加载场景
    /// </summary>
    /// <param name="name"></param>
    public void LoadScene(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            Debug.Log("场景名字不能为空");
            return;
        }
        SceneManager.LoadScene(name);
    }
}


/// <summary>
/// 场景名字
/// </summary>
public class SceneName
{
    public static string Login = "Login";//登陆
    public static string Game_3_3 = "Game_3_3";//三人游戏
}