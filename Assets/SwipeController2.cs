using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SwipeController2 : MonoBehaviour
{
    [SerializeField] int maxPage;
    int currentPage;
    Vector3 targetPos;
    [SerializeField] Vector3 pageStep;
    [SerializeField] RectTransform levelPagesRect;

    [SerializeField] float tweenTime;
    [SerializeField] LeanTweenType tweenType;

    [SerializeField] Image[] barImage;
    [SerializeField] Sprite barClosed, barOpen;

    [SerializeField] GameObject[] pageObjects;

    private void Awake()
    {
        currentPage = 1;
        targetPos = levelPagesRect.localPosition;
        UpdateBar();
        UpdateObjects();
    }

    public void Next()
    {
        if (currentPage < maxPage)
        {
            currentPage++;
            targetPos += pageStep;
            MovePage();
        }
    }

    public void Previous()
    {
        if (currentPage > 1)
        {
            currentPage--;
            targetPos -= pageStep;
            MovePage();
        }
    }

    void MovePage()
    {
        levelPagesRect.LeanMoveLocal(targetPos, tweenTime).setEase(tweenType);
        UpdateBar();
        UpdateObjects();
    }

    void UpdateBar()
    {
        foreach (var item in barImage)
        {
            item.sprite = barClosed;
        }
        barImage[currentPage - 1].sprite = barOpen;
    }

    void UpdateObjects()
    {
        // Pastikan semua objek 3D nonaktif dulu
        for (int i = 0; i < pageObjects.Length; i++)
        {
            if (pageObjects[i] != null)
                pageObjects[i].SetActive(false);
        }

        // Aktifkan hanya objek yang sesuai dengan halaman sekarang
        if (currentPage - 1 < pageObjects.Length && pageObjects[currentPage - 1] != null)
        {
            pageObjects[currentPage - 1].SetActive(true);
        }
    }

}
