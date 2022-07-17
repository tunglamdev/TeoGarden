import Button from 'react-bootstrap/Button';
import { useState } from "react";
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Categories from './index';
import categoryApi from "../../api/categoryApi";
import {useNavigate, useParams} from "react-router-dom";

function Delete() {
    const [show] = useState(true);
    const refresh = useNavigate();
    const {id} = useParams();

    const deleteCategory = async () => {
        var res = await categoryApi.Delete(id);
        refresh(-1);
    }

    return (
        <>
            <Categories />

            <Modal show={show} backdrop="static">
                <Modal.Header>
                    <Modal.Title>Xóa loại sản phẩm</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    Bạn chắc chắn muốn xóa loại sản phẩm này? 
                    Tất cả sản phẩm thuộc loại này sẽ bị xóa?
                </Modal.Body>
                <Modal.Footer>
                    <Link to="/categories"><Button variant="secondary">Thoát</Button></Link>
                    <Button onClick={deleteCategory} variant="danger">Xóa</Button>
                </Modal.Footer>
            </Modal>
        </>
    );
}

export default Delete;