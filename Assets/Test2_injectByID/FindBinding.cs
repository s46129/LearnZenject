using UnityEngine;
using Zenject;

namespace Test2_injectByID
{
    public class FindBinding : MonoBehaviour
    {
        [Inject(Id = "Player2")] PlayerTestByID playerTestForBinding;

        void Start()
        {
            playerTestForBinding.Trigger();
            Debug.Log("FindBinding finished");
        }
    }
}