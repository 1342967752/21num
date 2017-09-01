using System.Collections.Generic;

/// <summary>
/// 操作行为
/// </summary>
public class ActionInfo {
    public Dictionary<int, List<CardInfo>> dealDic;//发牌数组

    public ActionType actionType = ActionType.None;//操作类型

    public CardInfo card;//操作的卡片
}


public enum ActionType
{
    None,//无操作
    GetCard,//拿牌
    NotNeed,//不加牌
    ViewCard,//看牌
    DealCard,//发牌
    ShuffleCard,//洗牌
}