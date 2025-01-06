using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class DifficultyScript : MonoBehaviour
{
    const string PrefName = "optionvalue";
    private TMP_Dropdown _dropdown;

    void Awake()
    {
        _dropdown = GetComponent<TMP_Dropdown>();
        _dropdown.onValueChanged.AddListener(new UnityAction<int>(index =>
        {
            PlayerPrefs.SetInt(PrefName, _dropdown.value);
            PlayerPrefs.Save();
        }));
    }
    void Start()
    {
        _dropdown.value = PlayerPrefs.GetInt(PrefName, 0);
    }
}
