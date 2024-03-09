using UnityEngine;

namespace Game
{
    public abstract class View : MonoBehaviour
    {
        protected void Enable()
        {
            gameObject.SetActive(true);
        }

        protected void Disable()
        {
            gameObject.SetActive(false);
        }
    }
}