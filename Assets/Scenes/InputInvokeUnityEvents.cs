using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InputInvokeUnityEvents : MonoBehaviour
{
  /// <summary>情報を表示させるテキストオブジェクト。</summary>
  [SerializeField] private Text TextObject;

  /// <summary>
  /// Move 操作を行ったときに呼ばれる。
  /// </summary>
  /// <param name="context">コールバック内容。</param>
  public void OnMove(InputAction.CallbackContext context)
  {
    var vec = context.ReadValue<Vector2>();
    TextObject.text = $"Move:({vec.x:f2}, {vec.y:f2})\n{TextObject.text}";
  }

  /// <summary>
  /// Move 操作を行ったときに呼ばれる。
  /// </summary>
  /// <param name="context">コールバック内容。</param>
  public void OnAttack(InputAction.CallbackContext context)
  {
    var value = context.ReadValueAsButton();
    TextObject.text = $"Attack:{value}\n{TextObject.text}";
  }
}
