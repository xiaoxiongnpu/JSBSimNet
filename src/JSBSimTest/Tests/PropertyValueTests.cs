#region Copyright(C)  Licensed under GNU GPL.
/// Copyright (C) 2005-2020 Agustin Santos Mendez
/// 
/// JSBSim was developed by Jon S. Berndt, Tony Peden, and
/// David Megginson. 
/// Agustin Santos Mendez implemented and maintains this C# version.
/// 
/// This program is free software; you can redistribute it and/or
/// modify it under the terms of the GNU General Public License
/// as published by the Free Software Foundation; either version 2
/// of the License, or (at your option) any later version.
///  
/// This program is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/// GNU General Public License for more details.
///  
/// You should have received a copy of the GNU General Public License
/// along with this program; if not, write to the Free Software
/// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
/// 
/// Further information about the GNU Lesser General Public License can also be found on
/// the world wide web at http://www.gnu.org.
#endregion

namespace JSBSim.Tests
{
    using System;
    using JSBSim.InputOutput;
    using JSBSim.MathValues;
    using NUnit.Framework;

    /// <summary>
    /// Represents a property value which can use late binding.
    /// </summary>
    [TestFixture]
    public class PropertyValueTests
    {
        private const double tolerance = 10E-16;

        [Test]
        public void CheckValidValue()
        {
            PropertyManager propertyManager = new PropertyManager();

            var propValue = new PropertyValue("Test01", propertyManager);
            propValue.SetValue(10.0);
            Assert.AreEqual(0, propValue.GetValue());
            Assert.AreEqual("constant value 0", propValue.GetName());
            Assert.AreEqual(true, propValue.IsConstant());
        }

    }
}