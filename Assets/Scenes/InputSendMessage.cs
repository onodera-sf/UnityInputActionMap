using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InputSendMessage : MonoBehaviour
{
  /// <summary>����\��������e�L�X�g�I�u�W�F�N�g�B</summary>
  [SerializeField] private Text TextObject;

  /// <summary>
  /// Move �A�N�V���������s���ꂽ�Ƃ��ɌĂ΂��B
  /// </summary>
  /// <param name="inputValue">���͓��e�B</param>
  public void OnMove(InputValue inputValue)
  {
    var vec = inputValue.Get<Vector2>();
    TextObject.text = $"Move:({vec.x:f2}, {vec.y:f2})\n{TextObject.text}";
  }

  /// <summary>
  /// Attack �A�N�V���������s���ꂽ�Ƃ��ɌĂ΂��B
  /// </summary>
  /// <param name="inputValue">���͓��e�B</param>
  public void OnAttack(InputValue inputValue)
  {
    TextObject.text = $"Attack:{inputValue.isPressed}\n{TextObject.text}";
  }
}
