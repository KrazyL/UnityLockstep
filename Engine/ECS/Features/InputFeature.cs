﻿using System;
using ECS.Systems.Input;
using ECS.Systems.Navigation;

namespace ECS.Features
{
    public sealed class InputFeature : Feature
    {
        public InputFeature(Contexts contexts, ServiceContainer serviceContainer)
        {    
            Add(new EmitInputSystem(contexts, serviceContainer.Get<IParseInputService>()));
            Add(new OnInputCreateGameEntity(contexts, serviceContainer.Get<IHashService>()));
            Add(new OnGameEntityLoadAsset(contexts, serviceContainer.Get<IViewService>()));
        }
    }
}