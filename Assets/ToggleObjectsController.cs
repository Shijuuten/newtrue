using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjectsController : MonoBehaviour
{
    [System.Serializable]
    public class ObjectPair
    {
        public GameObject objectA;
        public GameObject objectB;

        [HideInInspector] public bool isAActive = true; // default A aktif
    }

    [Header("Daftar Pasangan Objek")]
    public ObjectPair[] objectPairs;

    // Dipanggil oleh tombol
    public void TogglePair(int pairIndex)
    {
        if (pairIndex < 0 || pairIndex >= objectPairs.Length)
            return;

        ObjectPair pair = objectPairs[pairIndex];

        // Toggle status
        pair.isAActive = !pair.isAActive;

        // Terapkan perubahan
        pair.objectA.SetActive(pair.isAActive);
        pair.objectB.SetActive(!pair.isAActive);
    }

    private void Start()
    {
        // Set kondisi awal semua pasangan
        foreach (var pair in objectPairs)
        {
            pair.objectA.SetActive(pair.isAActive);
            pair.objectB.SetActive(!pair.isAActive);
        }
    }
}
