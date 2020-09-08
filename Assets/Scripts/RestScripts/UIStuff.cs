using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStuff : MonoBehaviour
{

    public MainScript Main;

    // Buttons
    public Button RestartButton;
    public Button ActiveBoomButton;
    public Button StartGameButton;

    // Texts
    public Text BombsLefText;

    public Text PlayerRotationText;
    public Text PlayerFallSpeedText;
    public Text PlayerBlockAmountText;
    public Text PlayerBombsAmountText;
    public Text PlayerBlockSizeXText;
    public Text PlayerBlockSizeYText;

    // Sliders

    public Slider PlayerRotationSlider;
    public Slider PlayerFallSpeedSlider;
    public Slider PlayerBlockAmountSlider;
    public Slider PlayerBombsAmountSlider;
    public Slider PlayerBlockSizeXSlider;
    public Slider PlayerBlockSizeYSlider;

    public List<Text> TextList;

    public List<Slider> SliderList;

    void Start()
    {
        RestartButton.gameObject.SetActive(false);

        TextList = new List<Text>
        {
            PlayerRotationText,
            PlayerFallSpeedText,
            PlayerBlockAmountText,
            PlayerBombsAmountText,
            PlayerBlockSizeXText,
            PlayerBlockSizeYText,
        };


        SliderList = new List<Slider>
        {
            PlayerRotationSlider,
            PlayerFallSpeedSlider,
            PlayerBlockAmountSlider,
            PlayerBombsAmountSlider,
            PlayerBlockSizeXSlider,
            PlayerBlockSizeYSlider,
        };

    }

}


