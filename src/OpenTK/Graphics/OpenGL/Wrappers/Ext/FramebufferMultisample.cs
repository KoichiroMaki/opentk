//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGL
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "FramebufferMultisample" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: EXT_framebuffer_multisample]
            /// Establish data storage, format, dimensions and sample count of a renderbuffer object's image
            /// </summary>
            /// <param name="target">
            /// Specifies a binding to which the target of the allocation and must be Renderbuffer.
            /// </param>
            /// <param name="samples">
            /// Specifies the number of samples to be used for the renderbuffer object's storage.
            /// </param>
            /// <param name="internalformat">
            /// Specifies the internal format to use for the renderbuffer object's image.
            /// </param>
            /// <param name="width">
            /// Specifies the width of the renderbuffer, in pixels.
            /// </param>
            /// <param name="height">
            /// Specifies the height of the renderbuffer, in pixels.
            /// </param>
            [AutoGenerated(Category = "EXT_framebuffer_multisample", Version = "", EntryPoint = "glRenderbufferStorageMultisampleEXT")]
            public static void RenderbufferStorageMultisample(OpenTK.Graphics.OpenGL.RenderbufferTarget target, int samples, OpenTK.Graphics.OpenGL.RenderbufferStorage internalformat, int width, int height)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(1987)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glRenderbufferStorageMultisampleEXT(OpenTK.Graphics.OpenGL.RenderbufferTarget target, int samples, OpenTK.Graphics.OpenGL.RenderbufferStorage internalformat, int width, int height);
        }
    }
}