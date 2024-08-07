/*************************************************************************
 *  Copyright (C) 2024 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  IUIMirror.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  2024/7/5
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.UI.Widget
{
    public interface IUIMirror : IUIWidget
    {
        bool IsMirror { get; }

        void SetMirror();

        void SetMirror(UIMirrorMode mode);
    }
}