using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Text loadingText; // 用於顯示載入進度的文字組件
    public Image progressBar; // 用於顯示進度條的圖片組件
    public Slider loadSlider; // 用於顯示進度條的滑動器組件
    private int curProgressValue = 0; // 當前的進度值

    private void FixedUpdate()
    {
        int progressValue = 100; // 最大進度值

        if (curProgressValue < progressValue)
        {
            curProgressValue++; // 遞增進度值
        }

        progressBar.fillMethod = Image.FillMethod.Horizontal;
        loadingText.text = "Loading..." + curProgressValue + "%"; // 更新載入文字
        progressBar.fillAmount = curProgressValue / 100f; // 更新進度條填充量
        loadSlider.value = curProgressValue / 100f; // 更新滑動器值

        if (curProgressValue == 100)
        {
            loadingText.text = "OK"; // 更新載入文字為 "OK"
            SceneManager.LoadScene("Menu"); // 加載 "Menu" 場景
        }
    }
}