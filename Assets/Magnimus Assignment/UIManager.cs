using UnityEngine;

namespace MagnimusAssignment
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private GameManager gameManager;

        // script will attached to buttons in Inspector
        public void OnClick(int i)
        {
            gameManager.ChangeWave(i);
        }
    }
}