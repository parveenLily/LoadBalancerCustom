/*
    This file is part of NetLoadBalancer, Daniele Fontani (https://github.com/zeppaman/.Net-Load-Balancer).

    NetLoadBalancer is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    NetLoadBalancer is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Nome-Programma.  If not, see <http://www.gnu.org/licenses/>.
*/
using NetLoadBalancer.Code.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetLoadBalancer.Code.Interfaces
{
    interface IScore
    {
         long GetScore(InternalProxyOptions proxyOptions);

        
    }
}
