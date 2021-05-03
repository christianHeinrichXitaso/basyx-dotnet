﻿/*******************************************************************************
* Copyright (c) 2020, 2021 Robert Bosch GmbH
* Author: Constantin Ziesche (constantin.ziesche@bosch.com)
*
* This program and the accompanying materials are made available under the
* terms of the Eclipse Public License 2.0 which is available at
* http://www.eclipse.org/legal/epl-2.0
*
* SPDX-License-Identifier: EPL-2.0
*******************************************************************************/
namespace BaSyx.Models.Core.AssetAdministrationShell.Identification.BaSyx
{
    public class BaSyxSubmodelIdentifier : UniformResourceName
    {
        public BaSyxSubmodelIdentifier(string submodelName, string version)
            : this(submodelName, version, null, null, null)
        { }

        public BaSyxSubmodelIdentifier(string submodelName, string version, string revision, string elementId, string instanceNumber) 
            : base(BaSyxUrnConstants.BASYX_NAMESPACE, BaSyxUrnConstants.BASYX_SUBMODELS, submodelName, version, revision, elementId, instanceNumber)
        { }
    }
}
