using TMPro;
using UnityEngine;

namespace Lessons.LS8_Timer.Scripts
{
    public class TimeTester: MonoBehaviour
    {
        [SerializeField] private TimerType _type;
        [SerializeField] private float _timerSeconds;
        [SerializeField] private TMP_Text _text;
        
        private Timer _timer;

        private void Awake()
        {
            _timer = new Timer(_type, _timerSeconds);
            _timer.OnTimerValueChangedEvent += OnTimerValueChanged;
            _timer.OnTimerFinishedEvent += OnTimerFinished;
        }

        private void OnDestroy()
        {
            _timer.OnTimerValueChangedEvent -= OnTimerValueChanged;
            _timer.OnTimerFinishedEvent -= OnTimerFinished;
        }

        private void Update()
        {
            _text.text = $"Value: {_timer.remainingSeconds} sec";
        }
        
        private void OnTimerFinished()
        {
            Debug.Log("Timer FINISHED");
        }
        
        private void OnTimerValueChanged(float obj)
        {
            Debug.Log($"Timer ticked. Remaining seconds: {_timer.remainingSeconds}");
        }

        public void StartTimerClicked()
        {
            _timer.Start();
        }

        public void PauseTimerClicked()
        {
            if (_timer.isPaused)
                _timer.Unpause();
            else 
                _timer.Pause();
        }

        public void StopTimerClicked()
        {
            _timer.Stop();
        }
    }
}