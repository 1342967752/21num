using UnityEngine;
using System.Collections.Generic;
using System;

public class GameMgr : Sington<GameMgr> ,GameStation{
    public int dealCardNum=2;//初始发牌数量

    //操作委托
    public delegate void Action(ActionInfo action);

    //无操作
    public Action ActionNUll;

    //拿牌
    public Action NeedCardAction;
    //不要牌
    public Action NotNeedAction;
    //看牌
    public Action ViewCardAction;
    //发牌
    public Action DealCardAction;
    //洗牌
    public Action ShuffleCardAction;
    //下庄
    public Action XiaZhuangAction;

    void Start()
    {
        Init();
        GameStart();
    }


    /// <summary>
    /// 操作
    /// </summary>
    public void Opreate(ActionInfo actionInfo)
    {
        if (actionInfo == null)
        {
            Debug.Log("操作为空");
            return;
        }
    }

    /// <summary>
    /// 处理
    /// </summary>
    /// <param name="actionInfo"></param>
    private void Handle(ActionInfo actionInfo)
    {
        switch (actionInfo.actionType)
        {
            case ActionType.None:
                if (ActionNUll != null)
                {
                    ActionNUll(actionInfo);
                }
                break;
            case ActionType.GetCard:
                if (NeedCardAction != null)
                {
                    NeedCardAction(actionInfo);
                }
                break;
            case ActionType.NotNeed:
                if (NotNeedAction != null)
                {
                    NotNeedAction(actionInfo);
                }
                break;
            case ActionType.ViewCard:
                if (ViewCardAction != null)
                {
                    ViewCardAction(actionInfo);
                }
                break;
            case ActionType.DealCard:
                if (DealCardAction != null)
                {
                    DealCardAction(actionInfo);
                }
                break;
            case ActionType.ShuffleCard:
                if (ShuffleCardAction != null)
                {
                    ShuffleCardAction(actionInfo);
                }
                break;
        }
    }

    /// <summary>
    /// 游戏开始
    /// </summary>
    public void GameStart()
    {
        ActionInfo action = new ActionInfo();
        action.actionType = ActionType.DealCard;
        List<int> playerIndexs = PlayerManager.Instance.GetAllPlayerIndex();
        action.dealDic = new Dictionary<int, List<CardInfo>>();
        for (int i = 0; i < playerIndexs.Count; i++)
        {
            List<CardInfo> cardInfos = new List<CardInfo>();
            for (int j = 0; j < dealCardNum; j++)
            {
                cardInfos.Add(CardPileMgr.Instance.GetCard());
            }
            action.dealDic.Add(playerIndexs[i], cardInfos);
        }

        Opreate(action);
    }

    public void GameEnd()
    {
        
    }

    public void GameReady()
    {
        
    }

    public void Init()
    {
        PlayerManager.Instance.Init();
        CardPileMgr.Instance.Init();
    }
}
