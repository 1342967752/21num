using UnityEngine;

/// <summary>
/// 牌的信息
/// </summary>
public class CardInfo : MonoBehaviour {

    public int cardPoint=-1;//牌的点数 用于显示

    public int cardWeight = -1;//卡牌权值  用于比较

    public CardColor cardColor = CardColor.None;//花色

    public int getCardPlayerIndex = -1;//牌属于的玩家

    public bool isUp = false;//是否正面向上
}

/// <summary>
/// 卡片花色
/// </summary>
public enum CardColor
{
   None,
   Heart,//红桃
   Spade,//黑桃
   Club,//梅花
   Diamond,//方块
   RedJoker,//大王
   BlackJoker//小王
}