

using System;

public class PlayerInfoCtx : EZData.Context
{
    //玩家名
    #region Property Name
    private readonly EZData.Property<string> _privateNameProperty
                    = new EZData.Property<string>();
    public EZData.Property<string> NameProperty
    { get { return _privateNameProperty; } }
    public string Name
    {
        get { return NameProperty.GetValue(); }
        set { NameProperty.SetValue(value); }
    }
    #endregion

    //玩家金币
    #region Property Gold
    private readonly EZData.Property<string> _privateGoldProperty
                    = new EZData.Property<string>();
    public EZData.Property<string> GoldProperty
    { get { return _privateGoldProperty; } }
    public string Gold
    {
        get { return GoldProperty.GetValue(); }
        set { GoldProperty.SetValue(value); }
    }
    #endregion

    //玩家头像
    #region Property HeadIcon
    private readonly EZData.Property<string> _privateHeadIconProperty
                    = new EZData.Property<string>();
    public EZData.Property<string> HeadIconProperty
    { get { return _privateHeadIconProperty; } }
    public string HeadIcon
    {
        get { return HeadIconProperty.GetValue(); }
        set { HeadIconProperty.SetValue(value); }
    }
    #endregion

}

/// <summary>
/// 玩家信息类
/// </summary>
public class PlayerInfo : IPlayer,GameStation
{
    public NguiRootContext context;
    private PlayerInfoCtx ctx;

    void Awake()
    {
        Init(); 
    }

    /// <summary>
    /// 玩家信息初始化
    /// </summary>
    private void Init()
    {
        //填充信息
        ctx = new PlayerInfoCtx();
        ctx.Name = name;
        ctx.HeadIcon = headIcon;
        ctx.Gold = gold+"";

        context.SetContext(ctx);
    }

    public override void NeedCardListenner(ActionInfo action)
    {
        
    }

    public override void NotNeedListenner(ActionInfo action)
    {
        
    }

    public override void ViewCardListenner(ActionInfo action)
    {
        
    }

    public override void DealCardListenner(ActionInfo action)
    {
        
    }

    public override void ShuffleCardListenner(ActionInfo action)
    {
       
    }

    public override void XiaZhuangListenner(ActionInfo action)
    {
        
    }

   

    void OnDestory()
    {
       
    }

    public override void GameEnd()
    {
        Debuger.Log("游戏结束");
    }

    public override void GameReady()
    {
        Debuger.Log("游戏准备");
    }

    public override void GameStart()
    {
        Debuger.Log("游戏开始");
    }

    void GameStation.Init()
    {
        throw new NotImplementedException();
    }
}

