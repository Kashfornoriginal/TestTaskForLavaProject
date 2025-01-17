﻿using Data.AssetsAdressable;
using Infrastructure.Factory.UIFactory;
using Infrastructure.GlobalStateMachine.StateMachine;
using UnityEngine.AddressableAssets;

namespace Infrastructure.GlobalStateMachine.States
{
    public class SceneLoadingState : State<GameInstance>
    {
        public SceneLoadingState(GameInstance context, IUIFactory uiFactory) : base(context)
        {
            _uiFactory = uiFactory;
        }

        private readonly IUIFactory _uiFactory;

        public override async void Enter()
        {
            ShowUI();
            
            var asyncOperationHandle = Addressables.LoadSceneAsync(AssetsAddressablesConstants.MAIN_MENU_LEVEL_NAME);
            await asyncOperationHandle.Task;
        
            OnLoadComplete();
        }

        private void ShowUI()
        {
            _uiFactory.CreateMenuLoadingScreen();
        }

        private void OnLoadComplete()
        {
            Context.StateMachine.SwitchState<MainMenuState>();
        }
    }
}