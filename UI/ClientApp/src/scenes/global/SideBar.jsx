import { useState } from "react";
import { Sidebar as ProSidebar, Menu, MenuItem, useProSidebar} from "react-pro-sidebar";
import { Typography, useTheme } from "@mui/material";
import { Link } from "react-router-dom";

import { tokens } from "../../theme";



const Sidebar = () => {
    const theme = useTheme();
    const colors = tokens(theme.palette.mode);
    const [isCollapsed, setIsCollapsed] = useState(false);
    const [selected, setSelected] = useState("Dashboard");
    const { collapseSidebar } = useProSidebar();
  
    return (
        <div style={{ display: 'flex', height: '100%' }}>
            <ProSidebar>
                <Menu>
                <MenuItem> Documentation</MenuItem>
                <MenuItem> Calendar</MenuItem>
                <MenuItem> E-commerce</MenuItem>
                </Menu>
            </ProSidebar>
            <main>
            <button onClick={() => collapseSidebar()}>Collapse</button>
        </main>
        </div>
      ); 
    }
//         <ProSidebar collapsed={isCollapsed}>
//           <Menu iconShape="square">
//             {/* LOGO AND MENU ICON */}
//             <MenuItem
//               onClick={() => setIsCollapsed(!isCollapsed)}
//               icon={isCollapsed ? <MenuOutlinedIcon /> : undefined}
//               style={{
//                 margin: "10px 0 20px 0",
//                 color: colors.grey[100],
//               }}
//             >
//               {!isCollapsed && (
//                 <Box
//                   display="flex"
//                   justifyContent="space-between"
//                   alignItems="center"
//                   ml="15px"
//                 >
//                   <Typography variant="h3" color={colors.grey[100]}>
//                     ADMINIS
//                   </Typography>
//                   <IconButton onClick={() => setIsCollapsed(!isCollapsed)}>
//                     <MenuOutlinedIcon />
//                   </IconButton>
//                 </Box>
//               )}
//             </MenuItem>
  
//             {!isCollapsed && (
//             <Box mb="25px">
//               <Box display="flex" justifyContent="center" alignItems="center">
//                 <img
//                   alt="profile-user"
//                   width="100px"
//                   height="100px"
//                   src={`../../assets/user.png`}
//                   style={{ cursor: "pointer", borderRadius: "50%" }}
//                 />
//               </Box>
//               <Box textAlign="center">
//                 <Typography
//                   variant="h2"
//                   color={colors.grey[100]}
//                   fontWeight="bold"
//                   sx={{ m: "10px 0 0 0" }}
//                 >
//                   Admin
//                 </Typography>
//                 <Typography variant="h5" color={colors.greenAccent[500]}>
//                   Admin
//                 </Typography>
//               </Box>
//             </Box>
//           )}
  
//   <Box paddingLeft={isCollapsed ? undefined : "10%"}>
//             <Item
//               title="Dashboard"
//               to="/"
//               icon={<HomeOutlinedIcon />}
//               selected={selected}
//               setSelected={setSelected}
//             />

//             <Typography
//               variant="h6"
//               color={colors.grey[300]}
//               sx={{ m: "15px 0 5px 20px" }}
//             >
//               Data
//             </Typography>
//             <Item
//               title="Usuarios"
//               to="/users"
//               icon={<PeopleOutlinedIcon />}
//               selected={selected}
//               setSelected={setSelected}
//             />
//             <Item
//               title="Establecimientos"
//               to="/establecimientos"
//               icon={<WarehouseIcon />}
//               selected={selected}
//               setSelected={setSelected}
//             />
//             <Item
//               title="Productos"
//               to="/productos"
//               icon={<ReceiptOutlinedIcon />}
//               selected={selected}
//               setSelected={setSelected}
//             />

//             <Typography
//               variant="h6"
//               color={colors.grey[300]}
//               sx={{ m: "15px 0 5px 20px" }}
//             >
//               Paginas
//             </Typography>
//             <Item
//               title="Transferir"
//               to="/transferir"
//               icon={<CalendarTodayOutlinedIcon />}
//               selected={selected}
//               setSelected={setSelected}
//             />
//               <Item
//               title="Operaciones"
//               to="/operaciones"
//               icon={<PersonOutlinedIcon />}
//               selected={selected}
//               setSelected={setSelected}
//             />
//             </Box>
//           </Menu>
//         </ProSidebar>
//       </Box>
//     );
//   };
  
  export default Sidebar;