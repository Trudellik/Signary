import { Input, Button } from 'antd';
import React, { useState } from 'react';

const EntrySignForm = () => {
  const [url, setUrl] = useState('');

  const handleSave = () => {
    console.log('Saved URL:', url);
    // Add your save logic here
  };

  const handleCancel = () => {
    setUrl('');
    console.log('Cancelled');
  };

  return (
    <div>
      <h2>EntrySignForm</h2>
      <div>
        <Input
          placeholder="Url"
          value={url}
          onChange={(e) => setUrl(e.target.value)}
        />
      </div>
      <div style={{ marginTop: '10px' }}>
        <Button type="primary" onClick={handleSave}>
          Save
        </Button>
        <Button style={{ marginLeft: '10px' }} onClick={handleCancel}>
          Cancel
        </Button>
      </div>
    </div>
  );
};

export default EntrySignForm;
