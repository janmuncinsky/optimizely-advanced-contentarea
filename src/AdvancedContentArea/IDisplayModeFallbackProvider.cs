// Copyright (c) Valdis Iljuconoks. All rights reserved.
// Licensed under Apache-2.0. See the LICENSE file in the project root for more information

using System.Collections.Generic;

namespace TechFellow.Optimizely.AdvancedContentArea;

public interface IDisplayModeFallbackProvider
{
    void Initialize();

    List<DisplayModeFallback> GetAll();
}
