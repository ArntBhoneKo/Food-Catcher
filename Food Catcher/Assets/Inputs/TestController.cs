//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/TestController.inputactions
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

public partial class @TestController : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TestController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TestController"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e97c8527-97b7-44b9-b3bb-e50459464b4f"",
            ""actions"": [
                {
                    ""name"": ""TouchPoint"",
                    ""type"": ""Value"",
                    ""id"": ""324f8782-77ee-4170-998f-87707f686d53"",
                    ""expectedControlType"": ""Touch"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5440d030-fb5a-46a1-b3a4-a92d9c1801a1"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPoint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_TouchPoint = m_Player.FindAction("TouchPoint", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_TouchPoint;
    public struct PlayerActions
    {
        private @TestController m_Wrapper;
        public PlayerActions(@TestController wrapper) { m_Wrapper = wrapper; }
        public InputAction @TouchPoint => m_Wrapper.m_Player_TouchPoint;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @TouchPoint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchPoint;
                @TouchPoint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchPoint;
                @TouchPoint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchPoint;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TouchPoint.started += instance.OnTouchPoint;
                @TouchPoint.performed += instance.OnTouchPoint;
                @TouchPoint.canceled += instance.OnTouchPoint;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnTouchPoint(InputAction.CallbackContext context);
    }
}
