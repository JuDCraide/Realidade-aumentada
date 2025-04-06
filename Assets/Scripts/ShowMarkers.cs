using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMarkers : MonoBehaviour {

    public GameObject[] markers;
    public int activeMarkerNumber = 0;
    public GameObject activeMarker = null;

    void Update() {
        if (Vaga.vaga != activeMarkerNumber) {
            activeMarkerNumber = Vaga.vaga;
            if (activeMarker != null) {
                activeMarker.SetActive(false);
            }
            if (activeMarkerNumber >= 16 && activeMarkerNumber <= markers.Length + 16) {
                activeMarker = markers[activeMarkerNumber - 16];
                activeMarker.SetActive(true);
            } else {
                activeMarker = null;
            }
        }
    }
}
