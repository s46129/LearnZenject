using UnityEngine;

namespace Test3_ProjectContainer
{
    public class SoundManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("sound manager started");
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void Trigger()
        {
            Debug.Log($"SoundManager Triggered");
        }
    }
}