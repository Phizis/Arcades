using UnityEngine;

    public abstract class BaseBlock : MonoBehaviour
    {
#if UNITY_EDITOR
        [HideInInspector]
        public BlocksData BlocksData;
#endif
    }