using UnityEngine;
using Zenject;

namespace Test1_FindWithZenjectBinding
{
    public class FindBinding : MonoBehaviour
    {
        [Inject] PlayerTestForBinding playerTestForBinding;

        void Start()
        {
            playerTestForBinding.Trigger();
            Debug.Log("FindBinding finished");
        }
    }
}