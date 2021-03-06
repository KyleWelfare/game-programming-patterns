//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Command"",
            ""id"": ""80b65d60-43d1-4aed-a9d0-7c57b3771f89"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6d29d822-d319-4d03-8f37-60e95ac1454f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeColor"",
                    ""type"": ""Button"",
                    ""id"": ""d771e58b-423f-4af1-94c0-d5fa5cc2a65f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""b6956931-ef1a-4839-a032-cd1890283a6b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Undo"",
                    ""type"": ""Button"",
                    ""id"": ""e403d984-c76b-42ff-a9e3-7a51a03bacee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""ffe0ee8c-b194-4bb6-a5e4-a2a3523d8c4a"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d0698ac5-13c1-4029-90fa-aa18fe1ec98e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1a9db2b6-8d52-4441-b584-b266e3aaf494"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f4368f4b-c61e-4d63-96ad-ddf3da4a9ef9"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e0451e7b-00d5-4f22-ac2c-d4cd83215dcb"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1dd39e13-bbba-4ae6-88e9-d6ec7ed8127c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeColor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a889da6-e8e0-4959-a83e-d436209d3103"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fa130b2-6124-402c-9798-d729e06c9ebc"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Undo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Command
        m_Command = asset.FindActionMap("Command", throwIfNotFound: true);
        m_Command_Move = m_Command.FindAction("Move", throwIfNotFound: true);
        m_Command_ChangeColor = m_Command.FindAction("ChangeColor", throwIfNotFound: true);
        m_Command_Rotate = m_Command.FindAction("Rotate", throwIfNotFound: true);
        m_Command_Undo = m_Command.FindAction("Undo", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Command
    private readonly InputActionMap m_Command;
    private ICommandActions m_CommandActionsCallbackInterface;
    private readonly InputAction m_Command_Move;
    private readonly InputAction m_Command_ChangeColor;
    private readonly InputAction m_Command_Rotate;
    private readonly InputAction m_Command_Undo;
    public struct CommandActions
    {
        private @PlayerInput m_Wrapper;
        public CommandActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Command_Move;
        public InputAction @ChangeColor => m_Wrapper.m_Command_ChangeColor;
        public InputAction @Rotate => m_Wrapper.m_Command_Rotate;
        public InputAction @Undo => m_Wrapper.m_Command_Undo;
        public InputActionMap Get() { return m_Wrapper.m_Command; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CommandActions set) { return set.Get(); }
        public void SetCallbacks(ICommandActions instance)
        {
            if (m_Wrapper.m_CommandActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CommandActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CommandActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CommandActionsCallbackInterface.OnMove;
                @ChangeColor.started -= m_Wrapper.m_CommandActionsCallbackInterface.OnChangeColor;
                @ChangeColor.performed -= m_Wrapper.m_CommandActionsCallbackInterface.OnChangeColor;
                @ChangeColor.canceled -= m_Wrapper.m_CommandActionsCallbackInterface.OnChangeColor;
                @Rotate.started -= m_Wrapper.m_CommandActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_CommandActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_CommandActionsCallbackInterface.OnRotate;
                @Undo.started -= m_Wrapper.m_CommandActionsCallbackInterface.OnUndo;
                @Undo.performed -= m_Wrapper.m_CommandActionsCallbackInterface.OnUndo;
                @Undo.canceled -= m_Wrapper.m_CommandActionsCallbackInterface.OnUndo;
            }
            m_Wrapper.m_CommandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @ChangeColor.started += instance.OnChangeColor;
                @ChangeColor.performed += instance.OnChangeColor;
                @ChangeColor.canceled += instance.OnChangeColor;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Undo.started += instance.OnUndo;
                @Undo.performed += instance.OnUndo;
                @Undo.canceled += instance.OnUndo;
            }
        }
    }
    public CommandActions @Command => new CommandActions(this);
    public interface ICommandActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnChangeColor(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnUndo(InputAction.CallbackContext context);
    }
}
