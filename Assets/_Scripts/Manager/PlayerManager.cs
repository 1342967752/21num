using System.Collections.Generic;

/// <summary>
/// 玩家管理器
/// </summary>
public class PlayerManager : Sington<PlayerManager>,GameStation {
    private Dictionary<int ,IPlayer> players=new Dictionary<int, IPlayer>();//玩家列表
    private Dictionary<PlayerDirction, IPlayer> playersDir = new Dictionary<PlayerDirction, IPlayer>();

    void Awake()
    {
        GameMgr.Instance.NeedCardAction += NeedCardListenner;
        GameMgr.Instance.NotNeedAction += NotNeedListenner;
        GameMgr.Instance.ViewCardAction += ViewCardListenner;
        GameMgr.Instance.ShuffleCardAction += ShuffleCardListenner;
        GameMgr.Instance.DealCardAction += DealCardListenner;
        GameMgr.Instance.XiaZhuangAction += XiaZhuangListenner;
    }

    public void Init()
    {

    }

    public void GameStart()
    {

    }

    public void GameEnd()
    {

    }

    public void GameReady()
    {

    }

    /// <summary>
    /// 注册玩家
    /// </summary>
    /// <param name="id"></param>
    public void ResgisterPlayer(int id)
    {
        if (players.ContainsKey(id))
        {
            Debuger.Log("已经被注册");
            return;
        }
    }

    /// <summary>
    /// 移除玩家
    /// </summary>
    /// <param name="id"></param>
    public void RemovePlayer(int id)
    {
        if (!players.ContainsKey(id))
        {
            Debuger.Log("该玩家没有注册");
            return;
        }
    }

    public  void NeedCardListenner(ActionInfo action)
    {

    }

    public  void NotNeedListenner(ActionInfo action)
    {

    }

    public  void ViewCardListenner(ActionInfo action)
    {

    }

    public  void DealCardListenner(ActionInfo action)
    {
        Debuger.Log("发牌");
    }

    public  void ShuffleCardListenner(ActionInfo action)
    {

    }

    public  void XiaZhuangListenner(ActionInfo action)
    {

    }



    /// <summary>
    /// 根据玩家index获取玩家
    /// </summary>
    /// <param name="playerIndex"></param>
    /// <returns></returns>
    public IPlayer FindPlayerInPlayers(int playerIndex)
    {
        IPlayer player = null;
        for (int i = 0; i < players.Count; i++)
        {
            if (players[i].playerIndex == playerIndex)
            {
                player = players[i];
                break;
            }
        }

        return player;
    }

    /// <summary>
    /// 获取所有玩家的index
    /// </summary>
    /// <returns></returns>
    public List<int> GetAllPlayerIndex()
    {
        if (players == null || players.Count == 0)
        {
            Debuger.Log("没有玩家");
            return null;
        }

        List<int> playerIndexs = new List<int>();
        for (int i = 0; i < players.Count; i++)
        {
            playerIndexs.Add(players[i].playerIndex);
        }

        return playerIndexs;
    }

    /// <summary>
    /// 判断是否有重复的玩家
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    private bool IsNotSameIndex(List<IPlayer> list)
    {
        if (players == null || players.Count == 0)
        {
            return false;
        }

        int temp = 0;
        for (int i = 0; i <list.Count ; i++)
        {
            temp = list[i].playerIndex;
            for (int j = i+1; j < list.Count; j++)
            {
                if (temp == list[j].playerIndex)
                {
                    return true;
                }
            }
        }

        return false;
    }

    void OnDestory()
    {
        GameMgr.Instance.NeedCardAction -= NeedCardListenner;
        GameMgr.Instance.NotNeedAction -= NotNeedListenner;
        GameMgr.Instance.ViewCardAction -= ViewCardListenner;
        GameMgr.Instance.ShuffleCardAction -= ShuffleCardListenner;
        GameMgr.Instance.DealCardAction -= DealCardListenner;
        GameMgr.Instance.XiaZhuangAction -= XiaZhuangListenner;

        if (PlayerManager.Instance != null)
        {
            Destroy(PlayerManager.Instance);
            PlayerManager.Instance = null;
        }
    }

   
}

/// <summary>
/// 玩家方位
/// </summary>
public enum PlayerDirction
{
    TopLeft,
    BottonLeft,
    TopRight,
}