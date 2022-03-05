using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InputInvokeUnityEvents : MonoBehaviour
{
  /// <summary>����\��������e�L�X�g�I�u�W�F�N�g�B</summary>
  [SerializeField] private Text TextObject;

  /// <summary>
  /// Move ������s�����Ƃ��ɌĂ΂��B
  /// </summary>
  /// <param name="context">�R�[���o�b�N���e�B</param>
  public void OnMove(InputAction.CallbackContext context)
  {
    var vec = context.ReadValue<Vector2>();
    TextObject.text = $"Move:({vec.x:f2}, {vec.y:f2})\n{TextObject.text}";
  }

  /// <summary>
  /// Move ������s�����Ƃ��ɌĂ΂��B
  /// </summary>
  /// <param name="context">�R�[���o�b�N���e�B</param>
  public void OnAttack(InputAction.CallbackContext context)
  {
    var value = context.ReadValueAsButton();
    TextObject.text = $"Attack:{value}\n{TextObject.text}";
  }
}
