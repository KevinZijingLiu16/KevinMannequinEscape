//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/SprintWeek/PlayerInput.inputactions
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

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""CharacterControl"",
            ""id"": ""7ca333eb-ee2e-4655-a1ee-aeeb7c0163ee"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""74fde0b9-eef0-4329-a012-b715e84175f5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""b3a1237d-88af-4afa-b4c9-855f4de70906"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToggleInventory"",
                    ""type"": ""Button"",
                    ""id"": ""a3c799d1-3907-4f2f-806d-6345aa5a7b16"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hadougen"",
                    ""type"": ""Button"",
                    ""id"": ""0a24ef00-f8ee-4291-a231-867b15be4a83"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InkAttack"",
                    ""type"": ""Button"",
                    ""id"": ""fdc0c862-1ff6-4599-87de-bfe789ea3e5f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e2c597ed-157f-4481-b122-bd28ad760cf3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""566a063d-89f9-414e-9405-0e5931451fce"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3595dfb2-9fe7-44a4-b7e0-e7462d36e2c1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9e7ce962-f949-4f36-a46b-d0eaf8e9c347"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a7f9836d-420a-4f0f-a823-5ef5e672f224"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e9f17547-b841-4f4f-8216-f6cdd4e375f5"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""366a1f1b-2518-4772-a98e-dd4589d23843"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3144e6ce-f7b5-4a7f-943f-2803a67924e2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hadougen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1525972-fc8f-4313-8e7d-1e0b53c6c8d9"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InkAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CharacterControl
        m_CharacterControl = asset.FindActionMap("CharacterControl", throwIfNotFound: true);
        m_CharacterControl_Move = m_CharacterControl.FindAction("Move", throwIfNotFound: true);
        m_CharacterControl_Run = m_CharacterControl.FindAction("Run", throwIfNotFound: true);
        m_CharacterControl_ToggleInventory = m_CharacterControl.FindAction("ToggleInventory", throwIfNotFound: true);
        m_CharacterControl_Hadougen = m_CharacterControl.FindAction("Hadougen", throwIfNotFound: true);
        m_CharacterControl_InkAttack = m_CharacterControl.FindAction("InkAttack", throwIfNotFound: true);
    }

    ~@PlayerInput()
    {
        UnityEngine.Debug.Assert(!m_CharacterControl.enabled, "This will cause a leak and performance issues, PlayerInput.CharacterControl.Disable() has not been called.");
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

    // CharacterControl
    private readonly InputActionMap m_CharacterControl;
    private List<ICharacterControlActions> m_CharacterControlActionsCallbackInterfaces = new List<ICharacterControlActions>();
    private readonly InputAction m_CharacterControl_Move;
    private readonly InputAction m_CharacterControl_Run;
    private readonly InputAction m_CharacterControl_ToggleInventory;
    private readonly InputAction m_CharacterControl_Hadougen;
    private readonly InputAction m_CharacterControl_InkAttack;
    public struct CharacterControlActions
    {
        private @PlayerInput m_Wrapper;
        public CharacterControlActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_CharacterControl_Move;
        public InputAction @Run => m_Wrapper.m_CharacterControl_Run;
        public InputAction @ToggleInventory => m_Wrapper.m_CharacterControl_ToggleInventory;
        public InputAction @Hadougen => m_Wrapper.m_CharacterControl_Hadougen;
        public InputAction @InkAttack => m_Wrapper.m_CharacterControl_InkAttack;
        public InputActionMap Get() { return m_Wrapper.m_CharacterControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControlActions set) { return set.Get(); }
        public void AddCallbacks(ICharacterControlActions instance)
        {
            if (instance == null || m_Wrapper.m_CharacterControlActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharacterControlActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
            @ToggleInventory.started += instance.OnToggleInventory;
            @ToggleInventory.performed += instance.OnToggleInventory;
            @ToggleInventory.canceled += instance.OnToggleInventory;
            @Hadougen.started += instance.OnHadougen;
            @Hadougen.performed += instance.OnHadougen;
            @Hadougen.canceled += instance.OnHadougen;
            @InkAttack.started += instance.OnInkAttack;
            @InkAttack.performed += instance.OnInkAttack;
            @InkAttack.canceled += instance.OnInkAttack;
        }

        private void UnregisterCallbacks(ICharacterControlActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @ToggleInventory.started -= instance.OnToggleInventory;
            @ToggleInventory.performed -= instance.OnToggleInventory;
            @ToggleInventory.canceled -= instance.OnToggleInventory;
            @Hadougen.started -= instance.OnHadougen;
            @Hadougen.performed -= instance.OnHadougen;
            @Hadougen.canceled -= instance.OnHadougen;
            @InkAttack.started -= instance.OnInkAttack;
            @InkAttack.performed -= instance.OnInkAttack;
            @InkAttack.canceled -= instance.OnInkAttack;
        }

        public void RemoveCallbacks(ICharacterControlActions instance)
        {
            if (m_Wrapper.m_CharacterControlActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharacterControlActions instance)
        {
            foreach (var item in m_Wrapper.m_CharacterControlActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharacterControlActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharacterControlActions @CharacterControl => new CharacterControlActions(this);
    public interface ICharacterControlActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnToggleInventory(InputAction.CallbackContext context);
        void OnHadougen(InputAction.CallbackContext context);
        void OnInkAttack(InputAction.CallbackContext context);
    }
}
