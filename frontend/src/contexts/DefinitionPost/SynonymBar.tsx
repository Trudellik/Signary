import { Button, Typography } from 'antd';
import React from 'react'

const { Title } = Typography;

interface SynonymBarProps {
    synonyms: string[]
}

const SynonymBar = ({ synonyms }:SynonymBarProps) => {
  if (!synonyms.length) {
    return ;
  }
  
    return (
    <div>
        <Title level={5}>Synonym</Title>
        {synonyms.map((s) => (
            <Button>{s}</Button>
        ))}
    </div>
  )
}

export default SynonymBar