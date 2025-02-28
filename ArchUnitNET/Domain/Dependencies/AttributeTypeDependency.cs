//  Copyright 2019 Florian Gather <florian.gather@tngtech.com>
// 	Copyright 2019 Paula Ruiz <paularuiz22@gmail.com>
// 	Copyright 2019 Fritz Brandhuber <fritz.brandhuber@tngtech.com>
// 
// 	SPDX-License-Identifier: Apache-2.0

namespace ArchUnitNET.Domain.Dependencies
{
    public class AttributeTypeDependency : TypeInstanceDependency
    {
        public AttributeTypeDependency(IType origin, AttributeInstance attributeInstance)
            : base(origin, attributeInstance)
        {
        }
    }
}