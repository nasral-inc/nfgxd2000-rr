using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    [SerializeField] private Text textFps;
    [SerializeField] private float updateInterval = 0.5f;

    private float accum = 0f;
    private int frames = 0;
    private float timeleft;
    private float fps;

    private void Start()
    {
        timeleft = updateInterval;
    }

    private void Update()
    {
        timeleft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        ++frames;

        if (timeleft <= 0.0)
        {
            fps = accum / frames;
            timeleft = updateInterval;
            accum = 0f;
            frames = 0;

            textFps.text = string.Format("{0:F2} FPS", fps);
        }
    }
}