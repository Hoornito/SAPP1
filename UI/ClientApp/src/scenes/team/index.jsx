import * as React from 'react';
import Box from '@mui/material/Box';
import { tokens } from "../../theme";
import { DataGrid, GridToolbar } from "@mui/x-data-grid";
import { useTheme } from "@mui/material";
import Header from "../../components/Header";
import CrearUsuarioDialog from "../../components/CreateUserDialog";
import Button from "@mui/material/Button";
import { useState } from "react";

const Usuarios = () => {
  const theme = useTheme();
  const colors = tokens(theme.palette.mode);
  const [showCreateUserDialog, setShowCreateUserDialog] = useState(false);

const columns = [
    {
      field: "email",
      headerName: "Usuario",
      width: 140
    },
    { field: "firstName", headerName: "Nombre", width: 140 },
    { field: "lastName", headerName: "Apellido", width: 140 },
    {
      field: "phoneNumber",
      headerName: "Teléfono",
      width: 140
    },
    {
      field: "fullName",
      headerName: "Nombre Completo",
      description: "This column has a value getter and is not sortable.",
      sortable: false,
      width: 220,
      valueGetter: (params) =>
        `${params.row.firstName || ""} ${params.row.lastName || ""}`
    }
  ];

const rows = [
  { id: 1, lastName: 'Snow', firstName: 'Jon', age: 35 },
  { id: 2, lastName: 'Lannister', firstName: 'Cersei', age: 42 },
  { id: 3, lastName: 'Lannister', firstName: 'Jaime', age: 45 },
  { id: 4, lastName: 'Stark', firstName: 'Arya', age: 16 },
  { id: 5, lastName: 'Targaryen', firstName: 'Daenerys', age: null },
  { id: 6, lastName: 'Melisandre', firstName: null, age: 150 },
  { id: 7, lastName: 'Clifford', firstName: 'Ferrara', age: 44 },
  { id: 8, lastName: 'Frances', firstName: 'Rossini', age: 36 },
  { id: 9, lastName: 'Roxie', firstName: 'Harvey', age: 65 },
];

  return (
    <Box m="20px">
      <Header
        title="Usuarios"
        subtitle="Lista de usuarios"
      />
      <CrearUsuarioDialog show={showCreateUserDialog} close={() => setShowCreateUserDialog(false)}/>
        <div className="m-2" >
        <Button variant="outlined" onClick={() => setShowCreateUserDialog(true)}>
        Crear usuario
        </Button>
        </div>
        <Box
        m="20px 0 0 0"
        height="60vh"
        sx={{
          "& .MuiDataGrid-root": {
            border: "none",
          },
          "& .MuiDataGrid-cell": {
            borderBottom: "none",
          },
          "& .name-column--cell": {
            color: colors.greenAccent[300],
          },
          "& .MuiDataGrid-columnHeaders": {
            backgroundColor: colors.blueAccent[700],
            borderBottom: "none",
          },
          "& .MuiDataGrid-virtualScroller": {
            backgroundColor: colors.primary[400],
          },
          "& .MuiDataGrid-footerContainer": {
            borderTop: "none",
            backgroundColor: colors.blueAccent[700],
          },
          "& .MuiCheckbox-root": {
            color: `${colors.greenAccent[200]} !important`,
          },
          "& .MuiDataGrid-toolbarContainer .MuiButton-text": {
            color: `${colors.grey[100]} !important`,
          },
        }}
      >
        <DataGrid
          rows={rows}
          columns={columns}
          components={{ Toolbar: GridToolbar }}
        />
      </Box>
    </Box>
  );
}

export default Usuarios;