/*******************************************************************************
* Copyright (c) 2020, 2021 Robert Bosch GmbH
* Author: Constantin Ziesche (constantin.ziesche@bosch.com)
*
* This program and the accompanying materials are made available under the
* terms of the Eclipse Public License 2.0 which is available at
* http://www.eclipse.org/legal/epl-2.0
*
* SPDX-License-Identifier: EPL-2.0
*******************************************************************************/
using BaSyx.Models.Connectivity.Descriptors;

namespace BaSyx.API.Clients
{
    public interface ISubmodelClientFactory
    {
        ISubmodelClient CreateSubmodelClient(ISubmodelDescriptor serviceDescriptor);
    }
}
