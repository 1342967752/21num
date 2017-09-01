using UnityEngine;

/// <summary>
/// 玩家的抽象类
/// </summary>
public abstract class IPlayer : MonoBehaviour {
    public int playerIndex=-1;//玩家唯一id
    public string name;//玩家名字
    public string headIcon;//头像名
    public bool isLand = false;//是否是庄家
    public int gold=2000;//玩家金币

    /// <summary>
    /// 玩家拿牌
    /// </summary>
    public abstract void NeedCardListenner(ActionInfo action);

    /// <summary>
    /// 不加牌
    /// </summary>
    /// <param name="action"></param>
    public abstract void NotNeedListenner(ActionInfo action);

    /// <summary>
    /// 看牌
    /// </summary>
    /// <param name="action"></param>
    public abstract void ViewCardListenner(ActionInfo action);

    /// <summary>
    /// 发牌
    /// </summary>
    /// <param name="action"></param>
    public abstract void DealCardListenner(ActionInfo action);

    /// <summary>
    /// 洗牌
    /// </summary>
    /// <param name="action"></param>
    public abstract void ShuffleCardListenner(ActionInfo action);

    /// <summary>
    /// 下庄
    /// </summary>
    /// <param name="action"></param>
    public abstract void XiaZhuangListenner(ActionInfo action);

    public abstract void GameEnd();

    public abstract void GameReady();

    public abstract void GameStart();
}

/// <summary>
/// 玩家状态
/// </summary>
public enum PlayerState
{
    Wait,//等待
    IsCheck,//被处理
}