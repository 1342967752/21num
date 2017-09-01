using UnityEngine;
using System.Collections;

public class MainPageMgr : Sington<MainPageMgr> {

    #region ctx
    public PageLoginCtx pageLoginCtx { get; private set; }
    #endregion

    #region Page
    public PageLogin pageLogin;
    #endregion

    public MainPageMgr()
    {
        pageLoginCtx = new PageLoginCtx();
    }
}
