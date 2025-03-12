using UnityEngine;
using System.Collections;
using DG.Tweening;
using TMPro;

public class CoinCounterUI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI current;
    [SerializeField] private TextMeshProUGUI toUpdate;
    [SerializeField] private Transform cointTextContainer;
    [SerializeField] private float duration;

    private float containerInitPosition;
    private float moveAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Canvas.ForceUpdateCanvases();
        current.SetText("0");
        toUpdate.SetText("0");
        containerInitPosition = cointTextContainer.localPosition.y;
        moveAmount = current.rectTransform.rect.height;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int score){
        toUpdate.SetText($"{score}");

        cointTextContainer.DOLocalMoveY(containerInitPosition + moveAmount, duration);
    }
}
