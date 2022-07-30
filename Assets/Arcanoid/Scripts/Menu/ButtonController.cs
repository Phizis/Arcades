using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private TextMeshProUGUI _buttonText;
    private int _index;

    public void SetData(Progress progress, int index)
    {
        _buttonText.text = (index + 1).ToString();
        _index = index;
        _button.interactable = progress.isOpened;
    }

    public void LevelSelected()
    {
        LoadingScreen.Screen.Enable(true);

        LevelIndex levelIndex = new LevelIndex();
        levelIndex.SetIndex(_index);

        Loader loader = new Loader();
        loader.LoadingMainScene(false);
    }
}
