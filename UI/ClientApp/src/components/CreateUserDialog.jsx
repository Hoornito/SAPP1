import * as React from "react";
import Button from "@mui/material/Button";
import TextField from "@mui/material/TextField";
import Dialog from "@mui/material/Dialog";
import DialogActions from "@mui/material/DialogActions";
import DialogContent from "@mui/material/DialogContent";
import DialogTitle from "@mui/material/DialogTitle";
import Divider from "@mui/material/Divider";


export default function CrearUsuarioDialog({show, close}) {

  return (
    <div>
      <Dialog open={show} onClose={close}>
        <DialogTitle>Crear usuario</DialogTitle>
        <DialogContent>
          <TextField
            autoFocus
            margin="dense"
            id="name"
            label="Nombre"
            type="email"
            variant="standard"
          />
          <Divider orientation="vertical" flexItem />
          <TextField
            autoFocus
            margin="dense"
            id="name"
            label="Apellido"
            type="email"
            variant="standard"
          />
          <Divider orientation="vertical" flexItem />
          <TextField
            autoFocus
            margin="dense"
            id="name"
            label="Email"
            type="email"
            variant="standard"
          />
          <Divider orientation="vertical" flexItem />
          <TextField
            autoFocus
            margin="dense"
            id="name"
            label="Usuario"
            type="email"
            variant="standard"
          />
          <Divider orientation="vertical" flexItem />
          <TextField
            autoFocus
            margin="dense"
            id="name"
            label="Contraseña"
            type="email"
            variant="standard"
          />
        </DialogContent>
        <DialogActions>
          <Button onClick={close}>Cancelar</Button>
          <Button onClick={close}>Crear</Button>
        </DialogActions>
      </Dialog>
    </div>
  );
}
