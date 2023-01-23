//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/SpaceShip/Scripts/SpaceShipInput.inputactions
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

public partial class @SpaceShipInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @SpaceShipInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SpaceShipInput"",
    ""maps"": [
        {
            ""name"": ""SpaceShip"",
            ""id"": ""5635eb1e-6eed-441c-9a44-811a36d3a16f"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""aa25bf34-0bc0-4237-9637-852a65411cfc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActivateEngine"",
                    ""type"": ""Button"",
                    ""id"": ""c88f49e2-d13b-481c-bccc-a74b6f6c91de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShootFirstWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""719c0c8a-66ed-4ea7-b821-95ea7362cf1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShootSecondWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""4ac98f76-530c-434c-9b4c-1ea76cd616fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""89a18ea6-be6d-4d20-81f6-4231ddf72416"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ActivateEngine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c44e3ed6-875c-4b8e-af86-8a6f599ff90f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ShootFirstWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5b234f0-7699-44d1-9f97-7bdc53c32881"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ShootSecondWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Angle"",
                    ""id"": ""e455643f-e3ed-473a-a34b-649923f4e333"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""84951d81-0ca2-41c9-9a62-9b7c11e3f605"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0a7f2cba-e384-49a3-81f9-21546a9edd77"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // SpaceShip
        m_SpaceShip = asset.FindActionMap("SpaceShip", throwIfNotFound: true);
        m_SpaceShip_Rotate = m_SpaceShip.FindAction("Rotate", throwIfNotFound: true);
        m_SpaceShip_ActivateEngine = m_SpaceShip.FindAction("ActivateEngine", throwIfNotFound: true);
        m_SpaceShip_ShootFirstWeapon = m_SpaceShip.FindAction("ShootFirstWeapon", throwIfNotFound: true);
        m_SpaceShip_ShootSecondWeapon = m_SpaceShip.FindAction("ShootSecondWeapon", throwIfNotFound: true);
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

    // SpaceShip
    private readonly InputActionMap m_SpaceShip;
    private ISpaceShipActions m_SpaceShipActionsCallbackInterface;
    private readonly InputAction m_SpaceShip_Rotate;
    private readonly InputAction m_SpaceShip_ActivateEngine;
    private readonly InputAction m_SpaceShip_ShootFirstWeapon;
    private readonly InputAction m_SpaceShip_ShootSecondWeapon;
    public struct SpaceShipActions
    {
        private @SpaceShipInput m_Wrapper;
        public SpaceShipActions(@SpaceShipInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_SpaceShip_Rotate;
        public InputAction @ActivateEngine => m_Wrapper.m_SpaceShip_ActivateEngine;
        public InputAction @ShootFirstWeapon => m_Wrapper.m_SpaceShip_ShootFirstWeapon;
        public InputAction @ShootSecondWeapon => m_Wrapper.m_SpaceShip_ShootSecondWeapon;
        public InputActionMap Get() { return m_Wrapper.m_SpaceShip; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SpaceShipActions set) { return set.Get(); }
        public void SetCallbacks(ISpaceShipActions instance)
        {
            if (m_Wrapper.m_SpaceShipActionsCallbackInterface != null)
            {
                @Rotate.started -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnRotate;
                @ActivateEngine.started -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnActivateEngine;
                @ActivateEngine.performed -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnActivateEngine;
                @ActivateEngine.canceled -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnActivateEngine;
                @ShootFirstWeapon.started -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShootFirstWeapon;
                @ShootFirstWeapon.performed -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShootFirstWeapon;
                @ShootFirstWeapon.canceled -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShootFirstWeapon;
                @ShootSecondWeapon.started -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShootSecondWeapon;
                @ShootSecondWeapon.performed -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShootSecondWeapon;
                @ShootSecondWeapon.canceled -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShootSecondWeapon;
            }
            m_Wrapper.m_SpaceShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @ActivateEngine.started += instance.OnActivateEngine;
                @ActivateEngine.performed += instance.OnActivateEngine;
                @ActivateEngine.canceled += instance.OnActivateEngine;
                @ShootFirstWeapon.started += instance.OnShootFirstWeapon;
                @ShootFirstWeapon.performed += instance.OnShootFirstWeapon;
                @ShootFirstWeapon.canceled += instance.OnShootFirstWeapon;
                @ShootSecondWeapon.started += instance.OnShootSecondWeapon;
                @ShootSecondWeapon.performed += instance.OnShootSecondWeapon;
                @ShootSecondWeapon.canceled += instance.OnShootSecondWeapon;
            }
        }
    }
    public SpaceShipActions @SpaceShip => new SpaceShipActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface ISpaceShipActions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnActivateEngine(InputAction.CallbackContext context);
        void OnShootFirstWeapon(InputAction.CallbackContext context);
        void OnShootSecondWeapon(InputAction.CallbackContext context);
    }
}
