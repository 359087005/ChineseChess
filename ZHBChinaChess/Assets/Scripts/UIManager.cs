using UnityEngine;
using UnityEngine.UI;
/// <summary>
///  //1，持有UIPanel以及其他UI的引用  控制UI显示 跳转 隐藏
///       //2，持有gamemanager的引用获取游戏相关信息
///       
/// 1，页面跳转   单机 单双难度 联网   退出
/// 2,加载游戏  开始游戏按钮触发
/// 3,悔棋 重玩 返回 下棋轮次提示 认输
/// </summary>
public class UIManager : MonoSingleton<UIManager>
{
    public GameObject[] panels;//0主菜单 1单机 2模式选择 3难度选择 4游戏面板 5联网游戏

    public Text tipUIText; //当前需要改变UI提示的text

    public Text[] tipUITexts;  //2个对应显示的UI引用  单机或者联网

    private void Start()
    {
    }

    private void Update()
    {
    }

    #region  页面跳转
    /// <summary>
    /// 单机模式
    /// </summary>
    public void StandaloneMode()
    {
        panels[0].SetActive(false);
        panels[1].SetActive(true);
    }
    /// <summary>
    /// 联网模式
    /// </summary>
    public void NetWorkingMode()
    {
        panels[0].SetActive(false);
        panels[5].SetActive(true);
        //TODO
    }
    /// <summary>
    /// 退出游戏
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }

    /// <summary>
    /// 单人模式
    /// </summary>
    public void PVEMode()
    {
        GameManager.Instance.chessPeople = 1;
        panels[2].SetActive(false);
        panels[3].SetActive(true);
    }
    /// <summary>
    /// 双人模式
    /// </summary>
    public void PVPMode()
    {
        GameManager.Instance.chessPeople = 2;
        tipUIText = tipUITexts[1];
        //游戏加载
        LoadGame();
    }

    /// <summary>
    /// 单机模式难度选择
    /// </summary>
    public void LevelMode(int level)
    {
        GameManager.Instance.currentLevel = level;
        tipUIText = tipUITexts[0];
        //游戏加载
        LoadGame();
    }
    #endregion
    #region 游戏操作
    /// <summary>
    /// 游戏加载
    /// </summary>
    private void LoadGame()
    {
        GameManager.Instance.InitGame();
        ResetUI();
        panels[4].SetActive(true);
    }

    private void ResetUI()
    {
        panels[2].SetActive(true);
        panels[3].SetActive(false);
        panels[1].SetActive(false);
        panels[0].SetActive(true);
    }


    /// <summary>
    /// 悔棋
    /// </summary>
    public void UnDo()
    {

    }
    /// <summary>
    /// 重玩
    /// </summary>
    public void Replay()
    {
    }
    /// <summary>
    /// 返回
    /// </summary>
    public void ReturnTo()
    {
    }
    /// <summary>
    /// 下棋轮次信息提示
    /// </summary>
    public void ShowTip(string str)
    {
        tipUIText.text = str;
    }
    /// <summary>
    /// 开始联网
    /// </summary>
    public void StartNetWorkingMode()
    {

    }
    /// <summary>
    /// 认输
    /// </summary>
    public void GiveUp()
    {

    }
    #endregion


}