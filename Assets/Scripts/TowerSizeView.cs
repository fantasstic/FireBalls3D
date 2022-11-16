using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TowerSizeView : MonoBehaviour
{
    [SerializeField] private Tower _tower;
    [SerializeField] private TMP_Text _sizeView;

    private void OnEnable()
    {
        _tower.SizeUpdate += OnSizeUpdate;
    }

    private void OnDisable()
    {
        _tower.SizeUpdate -= OnSizeUpdate;
    }

    private void OnSizeUpdate(int size)
    {
        _sizeView.text = size.ToString();
    }
}
