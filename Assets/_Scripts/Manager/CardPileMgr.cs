using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 牌堆
/// </summary>
public class CardPileMgr : Sington<CardPileMgr> {
    private int shuffleCardTime = 20;//洗牌次数


    /// <summary>
    /// 牌堆
    /// </summary>
    private List<CardInfo> cardPointList;

    //初始化
    public void Init()
    {
        cardPointList = new List<CardInfo>();
        CreateCardPile(cardPointList);
    }

    /// <summary>
    /// 创建牌堆
    /// </summary>
    /// <param name="list"></param>
    private void CreateCardPile(List<CardInfo> list)
    {
        list.Clear();

        for (int i = 1; i <= 15; i++)
        {
            if (i == 14|| i == 15)
            {
                list.Add(CreateCard(i, CardColor.None));
                continue;
            }
           
            list.Add(CreateCard(i, CardColor.Heart));
            list.Add(CreateCard(i, CardColor.Spade));
            list.Add(CreateCard(i, CardColor.Club));
            list.Add(CreateCard(i, CardColor.Diamond));
        }

        Debuger.Log("牌堆创建完成");
    }

    /// <summary>
    /// 创建单一的一张牌
    /// </summary>
    /// <param name="cardPoint"></param>
    /// <param name="cardColor"></param>
    /// <returns></returns>
    private CardInfo CreateCard(int cardPoint,CardColor cardColor)
    {
        CardInfo cardInfo = new CardInfo();

        switch (cardPoint)
        {
            case 1:
                cardInfo.cardPoint = cardPoint;
                cardInfo.cardWeight = 12;
                cardInfo.cardColor = cardColor;
                break;
            case 2:
                cardInfo.cardPoint = cardPoint;
                cardInfo.cardWeight = 13;
                cardInfo.cardColor = cardColor;
                break;
            default:
                cardInfo.cardPoint = cardPoint;
                cardInfo.cardWeight = cardPoint;
                cardInfo.cardColor = cardColor;
                break;

        }

        return cardInfo;
    }

    /// <summary>
    /// 洗牌
    /// </summary>
    public void ShuffleCard()
    {
        if (cardPointList == null || cardPointList.Count == 0)
        {
             Debug.Log("无牌可洗");
            return;
        }

        int rand = 0;
        int lenght = cardPointList.Count;
        for (int i = 0; i <shuffleCardTime; i++)
        {
            rand = (int)Random.Range(0, lenght - 0.1f);
            ExChangeCard(cardPointList, rand, i%(lenght-1));
        }

        Debug.Log("洗牌结束");
    }

    /// <summary>
    /// 交换两张卡片
    /// </summary>
    /// <param name="list"></param>
    /// <param name="index01"></param>
    /// <param name="index02"></param>
    private void ExChangeCard(List<CardInfo> list,int index01,int index02)
    {
        if (index01 >= list.Count || index02 >= list.Count)
        {
            Debug.Log("list长度不够:" + list.Count);
            return;
        }

        if (index01 == index02)
        {
            return;
        }

        CardInfo temp = list[index01];
        list[index01] = list[index02];
        list[index02] = temp;
    }

    /// <summary>
    /// 拿牌
    /// </summary>
    /// <returns></returns>
    public CardInfo GetCard()
    {
        if (cardPointList==null||cardPointList.Count == 0)
        {
            return null;
        }

        CardInfo cardInfo = cardPointList[0];
        cardPointList.RemoveAt(0);
        return cardInfo;
    }

    void OnDestory()
    {
        if (Instance != null)
        {
            Destroy(Instance);
            Instance = null;
        }
    }
}
