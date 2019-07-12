using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;



namespace ChinarX
{
    /// <summary>
    /// Chinar系统扩展类-用于简化高质量代码
    /// </summary>
    public static class ChinarSystemExtension
    {
        /// <summary>
        /// 关闭游戏对象
        /// </summary>
        public static void Off(this GameObject go)
        {
            go.SetActive(false);
        }


        /// <summary>
        /// 关闭游戏对象
        /// </summary>
        public static void Off(this Transform go)
        {
            go.gameObject.SetActive(false);
        }


        /// <summary>
        /// 激活游戏对象
        /// </summary>
        public static void On(this GameObject go)
        {
            go.SetActive(true);
        }


        /// <summary>
        /// 激活游戏对象
        /// </summary>
        public static void On(this Transform go)
        {
            go.gameObject.SetActive(true);
        }


        /// <summary>
        /// 设置父物体
        /// </summary>
        public static void SetParent(this GameObject go, GameObject parentGo)
        {
            go.transform.SetParent(parentGo == null ? null : parentGo.transform);
        }


        /// <summary>
        /// 设置父物体
        /// </summary>
        public static void SetParent(this GameObject go, [CanBeNull] Transform parentGo)
        {
            go.transform.SetParent(parentGo == null ? null : parentGo);
        }


        /// <summary>
        /// 获取组件
        /// </summary>
        public static T Get<T>(this GameObject go) where T : class
        {
            return go.GetComponent<T>();
        }


        /// <summary>
        /// 开启按钮
        /// </summary>
        /// <param name="isOn">是否激活按钮</param>
        public static void SetActive(this Button button, bool isOn = true)
        {
            button.GetComponent<Image>().raycastTarget = isOn;
            button.interactable                        = isOn;
        }


        /// <summary>
        /// 设置材质的散射光
        /// </summary>
        /// <param name="color">需要改变的颜色</param>
        public static void SetEmission(this Material material, Color color)
        {
            material.color = color;
            material.EnableKeyword("_EMISSION");
            material.SetColor("_EmissionColor", color);
        }
    }
}