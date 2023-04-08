using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFade : MonoBehaviour
{
      public GameObject desertNAcanvas;
      public GameObject forestNAcanvas;
      public GameObject mountainNAcanvas;

      public void desertFade()
      {
            StartCoroutine(desertFadeWaiter());
      }

      public void forestFade()
      {
            StartCoroutine(forestFadeWaiter());
      }

      public void mountainFade()
      {
            StartCoroutine(mountainFadeWaiter());
      }

      public IEnumerator desertFadeWaiter()
      {
            forestNAcanvas.GetComponent<CanvasGroup>().alpha = 0;
            mountainNAcanvas.GetComponent<CanvasGroup>().alpha = 0;
            desertNAcanvas.GetComponent<CanvasGroup>().alpha = 1;
            yield return new WaitForSecondsRealtime(3);
            desertNAcanvas.GetComponent<CanvasGroup>().alpha = 0;
      }

      public IEnumerator forestFadeWaiter()
      {
            desertNAcanvas.GetComponent<CanvasGroup>().alpha = 0;
            mountainNAcanvas.GetComponent<CanvasGroup>().alpha = 0;
            forestNAcanvas.GetComponent<CanvasGroup>().alpha = 1;
            yield return new WaitForSecondsRealtime(3);
            forestNAcanvas.GetComponent<CanvasGroup>().alpha = 0;
      }

      public IEnumerator mountainFadeWaiter()
      {
            desertNAcanvas.GetComponent<CanvasGroup>().alpha = 0;
            forestNAcanvas.GetComponent<CanvasGroup>().alpha = 0;
            mountainNAcanvas.GetComponent<CanvasGroup>().alpha = 1;
            yield return new WaitForSecondsRealtime(3);
            mountainNAcanvas.GetComponent<CanvasGroup>().alpha = 0;
      }

      

}
