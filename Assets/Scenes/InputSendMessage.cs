using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InputSendMessage : MonoBehaviour
{
  /// <summary>情報を表示させるテキストオブジェクト。</summary>
  [SerializeField] private Text TextObject;

  /// <summary>
  /// Move アクションが実行されたときに呼ばれる。
  /// </summary>
  /// <param name="inputValue">入力内容。</param>
  public void OnMove(InputValue inputValue)
  {
    var vec = inputValue.Get<Vector2>();
    TextObject.text = $"Move:({vec.x:f2}, {vec.y:f2})\n{TextObject.text}";
  }

  /// <summary>
  /// Attack アクションが実行されたときに呼ばれる。
  /// </summary>
  /// <param name="inputValue">入力内容。</param>
  public void OnAttack(InputValue inputValue)
  {
    TextObject.text = $"Attack:{inputValue.isPressed}\n{TextObject.text}";
  }
}
