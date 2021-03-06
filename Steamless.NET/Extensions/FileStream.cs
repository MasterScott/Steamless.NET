﻿/**
 * Steamless Steam DRM Remover
 * (c) 2015 atom0s [atom0s@live.com]
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see http://www.gnu.org/licenses/
 */

namespace Steamless.NET.Extensions
{
    using System.IO;

    public static class FileStreamExtensions
    {
        /// <summary>
        /// Writes a byte array to the file stream.
        /// </summary>
        /// <param name="fStream"></param>
        /// <param name="data"></param>
        public static void WriteBytes(this FileStream fStream, byte[] data)
        {
            fStream.Write(data, 0, data.Length);
        }
    }
}