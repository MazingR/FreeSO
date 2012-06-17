﻿/*The contents of this file are subject to the Mozilla Public License Version 1.1
(the "License"); you may not use this file except in compliance with the
License. You may obtain a copy of the License at http://www.mozilla.org/MPL/

Software distributed under the License is distributed on an "AS IS" basis,
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for
the specific language governing rights and limitations under the License.

The Original Code is the TSO LoginServer.

The Initial Developer of the Original Code is
Mats 'Afr0' Vederhus. All Rights Reserved.

Contributor(s): Nicholas Roth.
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace SimsLib.IFF
{
    public class SpriteFrame
    {
        private uint m_FrameIndex;
        private uint m_Version, m_Size;     //These are only stored in version 1001
        private ushort m_Width, m_Height;
        private uint m_Flag;
        private ushort m_PaletteID;
        private PaletteMap m_PalMap;
        private Color m_TransparentPixel;
        private ushort m_X, m_Y;
        private FastPixel m_BitmapData;

        /// <summary>
        /// Stored for frames that are in SPR2s version 1000.
        /// NOT part of a frame in the actual file!
        /// Should be equal to the index in the offsettable.
        /// </summary>
        public uint FrameIndex
        {
            get { return m_FrameIndex; }
            set { m_FrameIndex = value; }
        }

        /// <summary>
        /// Stored in version 1001. Value is
        /// invariably 1001.
        /// </summary>
        public uint Version
        {
            get { return m_Version; }
            set { m_Version = value; }
        }

        /// <summary>
        /// The size of this compressed frame, in bytes.
        /// Only stored in version 1001.
        /// </summary>
        public uint Size
        {
            get { return m_Size; }
            set { m_Size = value; }
        }

        public ushort Width
        {
            get { return m_Width; }
            set { m_Width = value; }
        }

        public ushort Height
        {
            get { return m_Height; }
            set { m_Height = value; }
        }

        public uint Flag
        {
            get { return m_Flag; }
            set { m_Flag = value; }
        }

        public ushort PaletteID
        {
            get { return m_PaletteID; }
            set { m_PaletteID = value; }
        }

        public PaletteMap PalMap
        {
            get { return m_PalMap; }
            set { m_PalMap = value; }
        }

        /*public int TransparentPixel
        {
            get { return m_TransparentPixel; }
            set { m_TransparentPixel = value; }
        }*/

        public Color TransparentPixel
        {
            get { return m_TransparentPixel; }
            set { m_TransparentPixel = value; }
        }

        public ushort XLocation
        {
            get { return m_X; }
            set { m_X = value; }
        }

        public ushort YLocation
        {
            get { return m_Y; }
            set { m_Y = value; }
        }

        public FastPixel BitmapData
        {
            get { return m_BitmapData; }
            set { m_BitmapData = value; }
        }

        public SpriteFrame()
        {
        }

        public void Init(bool Alpha)
        {
            if (m_Width > 0 && m_Height > 0)
            {
                m_BitmapData = new FastPixel(new Bitmap(m_Width, m_Height), Alpha);
                m_BitmapData.Lock();
            }
            else
            {
                m_BitmapData = new FastPixel(new Bitmap(1, 1), Alpha);
                m_BitmapData.Lock();
            }
        }
    }
}
