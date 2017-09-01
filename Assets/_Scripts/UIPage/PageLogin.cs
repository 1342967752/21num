using UnityEngine;

public class PageLoginCtx:EZData.Context
{

    #region Property bb
    private readonly EZData.Property<bool> _privatebbProperty
                    = new EZData.Property<bool>();
    public EZData.Property<bool> bbProperty
    { get { return _privatebbProperty; } }
    public bool bb
    {
        get { return bbProperty.GetValue(); }
        set { bbProperty.SetValue(value); }
    }
    #endregion
    public void ToLogin()
    {
        SceneMgr.Instance.LoadScene(SceneName.Game_3_3);
    }
}

/// <summary>
/// 登陆界面
/// </summary>
public class PageLogin : MonoBehaviour {
    private PageLoginCtx ctx;
    public NguiRootContext content;

	void Awake()
    {
        ctx = MainPageMgr.Instance.pageLoginCtx;
        MainPageMgr.Instance.pageLogin = this;
        content.SetContext(ctx);
    }
}
