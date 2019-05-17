using UnityEngine;

/// <summary>
/// 1,存储游戏数据
/// 2,游戏引用
/// 3,游戏资源
/// 4,模式切换与控制 联网控制
/// </summary>
public class GameManager : MonoSingleton<GameManager> 
{
    public int chessPeople; //当前对战人数


    public int currentLevel; //   1   2    3
    private void Start()
    {
        
    }

    private void Update()
    {
    }


    public void InitGame()
    {
        //1,属性值重置
        //2，实例化棋盘跟棋子
        //3,游戏进行中游戏时间内UI显示
    }

}
